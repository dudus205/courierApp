<template>
  <div v-if="loading" class="d-flex flex-column justify-center full-width flex-wrap align-stretch">
    <p class="text-h6">Trwa wyliczanie najkorzystniejszej trasy...</p>
    <v-progress-circular indeterminate color="primary" size="100"></v-progress-circular>
  </div>
  <div v-else>
    <p class="text-h6">Najbardziej optymalna trasa.</p>
    <iframe
        src="https://www.google.com/maps/embed?pb=!1m46!1m12!1m3!1d40285.500235888525!2d20.571358065481533!3d50.87109207664178!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!4m31!3e0!4m5!1s0x471827a176740bf5%3A0x7b189a21ae5038dd!2sDPD%20Polska%2C%20Rolna%2C%20Kielce!3m2!1d50.876061!2d20.6605653!4m5!1s0x4718279523b7cae1%3A0x5443ac7f9dc2bfb7!2sWarszawska%2026%2C%20Kielce!3m2!1d50.875662299999995!2d20.636083!4m5!1s0x471828154904cbc9%3A0x4d61b0800254c0b5!2sTektoniczna%2035%2C%20Kielce!3m2!1d50.888334099999994!2d20.5779498!4m5!1s0x4717880730c384d1%3A0xfacdb34e908ec6ac!2sKrakowska%20177%2C%20Kielce!3m2!1d50.858927099999995!2d20.5895889!4m5!1s0x471787ede08cbbcf%3A0xfaad7865b061909c!2sKolonia%2041%2C%20Kielce!3m2!1d50.8579855!2d20.5612662!5e0!3m2!1spl!2spl!4v1656428088390!5m2!1spl!2spl"
        width="800" height="600" style="border:0;" allowfullscreen="" loading="lazy"
        referrerpolicy="no-referrer-when-downgrade"></iframe>
  </div>
</template>

<script>
export default {
  name: "AppMap",
  data() {
    return {
      loading: true
    }
  },
  mounted() {
    setTimeout(() => this.loading = false, 3000);
  }
}
</script>

<style scoped>

</style>