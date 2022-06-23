<template>
  <v-app>
    <AppNavigationDrawer></AppNavigationDrawer>
    <AppToolbar></AppToolbar>
    <v-main class="ma-4">
      <router-view></router-view>
    </v-main>
  </v-app>
</template>

<script>
import AppToolbar from "@/components/AppToolbar";
import AppNavigationDrawer from "@/components/AppNavigationDrawer";

export default {
  name: "DefaultLayout",
  components: {AppNavigationDrawer, AppToolbar}

}
</script>