<template>
  <div>
    <qrcode-scanner
        :qrbox="250"
        :fps="10"
        @result="onScan"
    />
    <div id="list" v-if="places.length > 0">
      <button id="send" @click="sendPlaces">Send</button>
      <ul>
        <p>List of places</p>
        <li v-for="place in places" :key="place.id">
          <p>x:{{ place.x }} y:{{ place.y }}</p>
          <button id="delete" @click="deletePlace(place.id)">Delete</button>
        </li>
      </ul>
    </div>
  </div>
</template>

<script>
import qrcodeScanner from "@/components/qrcode-scanner";

export default {
  components: {
    qrcodeScanner
  },
  data() {
    return {
      places: []
    }
  },
  methods: {
    onScan(decodedText) {
      const xDecoded = decodedText.substring(decodedText.search("x:") + 3, decodedText.search("y:") - 2)
      // console.log(xDecoded);
      const yDecoded = decodedText.substring(decodedText.search("y:") + 3, decodedText.search("}"))
      //console.log(this.places.length);
      //console.log(this.places.length)
      if(this.places.length === 0)
        this.places.push({
          id: this.places.length - 1,
          x: xDecoded,
          y: yDecoded
        });
      else if(this.places[this.places.length - 1].x !== xDecoded && this.places[this.places.length - 1].y !== yDecoded)
        this.places.push({
          id: this.places.length -1 ,
          x: xDecoded,
          y: yDecoded
        });
      // console.log(yDecoded);

    },
    deletePlace(index){
      this.places.splice(index, 1)
    },
    sendPlaces(){
      console.log("send table to api")
    }
  }
}
</script>
<style>
#send{
  background-color: #14213d;
  color: #fca311;
  border-radius: 5px;
  border: 1px solid #e5e5e5;
  transition: background-color 0.2s;
  opacity: 80%;
}
#send:hover{
  color: #e5e5e5;
  opacity: 100%;
  transition: 0.2s;
}
#list{
  background-color: #e5e5e5;
  margin: 15px 0;
  padding: 15px 0 5px 0;
  border-radius: 10px;
  border: 1px solid #ffffff;
}

#send{
  margin: 0 auto;
  padding: 5px 10px;
  display: block;
}
ul{
  background: #e5e5e5;
  padding: 10px 35px;
}
qrcode-scanner{
  width: 100%;
}
#delete{
  background: #fca311;
  color: #000000;
  padding: 5px;
  border-radius: 3px;
  border: 1px solid #14213d;
  transition: background-color 0.2s;
}
#delete:hover{
  background: #e5e5e5;
  transition: background-color 0.2s;
}
</style>
