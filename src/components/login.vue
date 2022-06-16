<template>
  <div id="login">
    <form>
      <label for="username">Username:</label><br>
      <input type="text" id="username" name="username"><br>
      <label for="pwd">Password:</label><br>
      <input type="password" id="pwd" name="pwd"><br><br>
      <router-link id="send" tag="button" to="/scanner" @click="loginToSystem">
        Login
      </router-link>
    </form>
  </div>
</template>

<script>
export default {
  name: "login",
  methods: {
    loginToSystem() {
      const username = document.getElementById("username").value;
      const password = document.getElementById("pwd").value;

      alert(username + " " + password);
    }
  }
}
</script>

<style scoped>
#login {
  background-color: #e5e5e5;
  text-align: center;
  padding: 30px;
  border-radius: 10px;
  border: 1px solid #e5e5e5;
}

</style>
