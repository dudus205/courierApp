<template>
  <v-switch class="mt-5"
      v-model="$vuetify.theme.dark"
      prepend-icon="mdi-moon-waning-crescent"
      inset
      persistent-hint
  ></v-switch>
</template>

<script>
export default {
  name: "AppDarkmodeToggle"
}
</script>

<style scoped>

</style>