<template>
  <v-container fill-height fluid class="login justify-center">
    <v-col cols="6">
      <v-card text color="">
        <v-card-title>Smart kurier</v-card-title>
        <v-card-subtitle>Projekt IUI - 2022</v-card-subtitle>
        <v-card-text class="pt-4">
          <v-text-field
              label="E-mail"
              v-model="email"
              :rules="emailRules"
              outlined
              required
          ></v-text-field>
          <v-text-field
              label="Hasło"
              v-model="password"
              min="8"
              :append-icon="e1 ? 'mdi-eye' : 'mdi-eye-off'"
              :append-icon-cb="() => (e1 = !e1)"
              :type="e1 ? 'password' : 'text'"
              :rules="passwordRules"
              outlined
              required
          ></v-text-field>
          <v-layout justify-space-between>
            <v-btn plain :to="{name: 'register'}">Zarejestruj się</v-btn>
            <v-btn @click="login" outlined>Zaloguj
            </v-btn>
          </v-layout>
        </v-card-text>
      </v-card>
    </v-col>
  </v-container>
</template>

<script>

import {TYPE} from "vue-toastification";

const passwordRegexp = /^\w+([.-]?\w+)*@\w+([.-]?\w+)*(\.\w{2,3})+$/;

export default {
  name: "AppLogin",
  data() {
    return {
      valid: false,
      e1: true,
      password: '',
      passwordRules: [
        (v) => !!v || 'Hasło jest wymagane',
      ],
      email: '',
      emailRules: [
        (v) => !!v || 'E-mail jest wymagany',
        (v) => passwordRegexp.test(v) || 'Proszę podać prawidłowy e-mail'
      ],
    }
  },
  methods: {
    async login() {
      const response = await this.$axios.post('user/login', {email: this.email, password: this.password});
      if (response.status === 200) {
        await this.$router.push({name: 'home'})
        this.$toast("Logowanie pomyślne!", {type: TYPE.SUCCESS})
      } else {
        this.$toast("Wprowadzone hasło jest nieprawidłowe", {type: TYPE.ERROR})
      }
    }
  }
}
</script>

<style scoped>
.login {
  background-image: url("https://images.unsplash.com/photo-1586528116311-ad8dd3c8310d?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1770&q=80") !important;
  background-size: cover;
  overflow: hidden;
}


</style>