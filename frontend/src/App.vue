<template>
  <div id="app">
<!--    <Header v-if="isLogin"></Header>-->
    <transition name="component-fade" mode="out-in">
      <router-view></router-view>
    </transition>
  </div>
</template>

<script>
// import Header from './components/Header.vue'

export default {
  name: 'App',
  // components: {
  //   Header
  // },
  computed: {
    isLogin() {
      console.log(this.$route.name)
      return this.$route.name !== 'login'
    }
  }

}
</script>

<style>
  body{
    background-color: #2091c4;
    padding: 0;
    margin: 10px 10% 0 10%;
    font-family: 'Titillium Web', sans-serif;
    min-width: 420px;
  }
  h1{
    font-size: 30px;
    text-align: left;
    margin: 5px 0 5px 10px;
  }
  .component-fade-enter-active, .component-fade-leave-active {
    transition: opacity 0.3s ease;
  }
  .component-fade-enter, .component-fade-leave-to {
    opacity: 0;
  }

</style>
