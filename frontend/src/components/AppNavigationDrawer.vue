<template>
  <v-navigation-drawer app color="grey lighten-5">
    <v-list-item>
      <v-list-item-content>
        <v-list-item-title class="text-h6">
          Inteligentny kurier
        </v-list-item-title>
        <v-list-item-subtitle>
          IUI - Projekt 2022
        </v-list-item-subtitle>
      </v-list-item-content>
    </v-list-item>

    <v-divider></v-divider>

    <v-list
        nav
        shaped
    >
      <v-list-item
          v-for="item in items"
          :key="item.title"
          link
          :to="item.route"
      >
        <v-list-item-icon>
          <v-icon color="secondary">{{ item.icon }}</v-icon>
        </v-list-item-icon>

        <v-list-item-content>
          <v-list-item-title>{{ item.title }}</v-list-item-title>
        </v-list-item-content>
      </v-list-item>
    </v-list>
  </v-navigation-drawer>
</template>

<script>
export default {
  name: "AppNavigationDrawer",
  data() {
    return {
      active: {},
      items: [
        {title: 'Strona główna', icon: 'mdi-home', route: '/home'},
        {title: 'Paczki', icon: 'mdi-truck', route: '/parcel'},
      ]
    }
  }
}
</script>

<style scoped>

</style>