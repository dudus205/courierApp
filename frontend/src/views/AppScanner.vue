<template>
  <div>
    <p class="text-h6">Zeskanuj kod QR paczki aby dodać ją do systemu.</p>
    <qrcode-stream @decode="onDecode"></qrcode-stream>
  </div>
</template>

<script>
import {QrcodeStream} from 'vue-qrcode-reader'
import {TYPE} from "vue-toastification";

export default {
  name: "AppScanner",
  components: {QrcodeStream},
  methods: {
    async onDecode(data) {
      const response = await this.$axios.post('parcel/add', JSON.parse(data));

      if (response.status === 200) {
        this.$toast('Pomyślnie dodano paczkę!', {type: TYPE.SUCCESS});
        await this.$router.push({name: 'parcel'})
      }
    },
  }
}
</script>

<style scoped>

</style>