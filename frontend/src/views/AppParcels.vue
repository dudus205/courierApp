<template>
  <v-layout column>
    <v-row>
      <v-col cols="12" class="justify-end">
        <v-btn depressed color="primary" class="mr-4">Wyznacz trasę</v-btn>
        <v-btn depressed color="success">Dodaj paczkę</v-btn>
      </v-col>
      <v-col cols="12">
        <v-data-table
            :headers="headers"
            :items="data"
        ></v-data-table>
      </v-col>
    </v-row>
  </v-layout>
</template>

<script>
export default {
  name: "AppParcels",
  data() {
    return {
      headers: [
        {
          text: 'ID',
          align: 'start',
          sortable: false,
          value: 'id',
        },
        {text: 'Ulica', value: 'street'},
        {text: 'Numer domu', value: 'houseNumber'},
        {text: 'Kraj', value: 'country'},
        {text: 'Miasto', value: 'city'},
        {text: 'Imię', value: 'name'},
        {text: 'Nazwisko', value: 'surname'},
      ],
      data: []
    }
  },
  async mounted() {
    const response = await this.$axios.get('parcel');

    if (response.status === 200) {
      this.data = response.data;
    }
  }
}
</script>

<style scoped>

</style>