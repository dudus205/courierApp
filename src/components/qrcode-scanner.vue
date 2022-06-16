<template>

  <div id="qr-code-full-region"></div>
</template>

<script>
import {Html5QrcodeScanner} from 'html5-qrcode'
export default {
name: "qrcode-scanner",
  props: {
    qrbox: {
      type: Number,
      default: 250
    },
    fps: {
      type: Number,
      default: 10
    },
  },
  template: `<div id="qr-code-full-region"></div>`,
  mounted () {
    const config = {
      fps: this.fps,
      qrbox: this.qrbox,
    };
    const html5QrcodeScanner = new Html5QrcodeScanner('qr-code-full-region', config);
    html5QrcodeScanner.render(this.onScanSuccess);
  },
  methods: {
    onScanSuccess (decodedText, decodedResult) {
      this.$emit('result', decodedText, decodedResult);
    }
  }
}
</script>

<style scoped>
#qr-code-full-region{
  background: #e5e5e5;
}
</style>
