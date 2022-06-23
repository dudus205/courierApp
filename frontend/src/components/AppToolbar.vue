<template>
  <v-app-bar height="68" class="bar" app flat outlined>

      <v-row class="justify-end mr-1">
        <v-avatar color="primary">
          <v-icon dark>
            mdi-account-circle
          </v-icon>
        </v-avatar>
      </v-row>

  </v-app-bar>

</template>

<script>
export default {
  name: "AppToolbar"
}
</script>

<style scoped lang="scss">
  .theme--light header {
    border-left: none !important;
    border-top: none !important;
    border-right: none !important;
    border-bottom: thin solid rgba(0, 0, 0, 0.12) !important;
    background: white !important;
  }

</style>