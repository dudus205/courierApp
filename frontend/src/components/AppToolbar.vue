<template>
  <v-app-bar height="68" class="bar" app flat outlined>
    <v-row class="justify-end mr-1">
      <AppDarkmodeToggle></AppDarkmodeToggle>
    </v-row>
  </v-app-bar>
</template>

<script>
import AppDarkmodeToggle from "@/components/AppDarkmodeToggle";

export default {
  name: "AppToolbar",
  components: {AppDarkmodeToggle}
}
</script>

<style scoped lang="scss">
header {
  border-left: none !important;
  border-top: none !important;
  border-right: none !important;
}

.theme--light header {
  border-bottom: thin solid rgba(0, 0, 0, 0.12) !important;
  background: white !important;
}

</style>