<template>
    <div>
        <h1>Stock trader</h1>
        <p>You can save and load state.</p>
        <p>Click "End Day" to start new day!</p>
        <hr>
        <p>Your funds: {{getMoney}}</p>
    </div>
</template>

<script>
    export default {
        name: "StockTrader",
        computed: {
            getMoney () {
              return this.$store.getters.getMoney;
            }
        },
    }
</script>

<style scoped>
    div{
        background-color: #ffffff;
        color: #000;
        width: calc(100% - 20px);
        box-shadow: 0 0 3px 1px #e5e5e5;
        padding: 10px 15px;
        margin-top: 15px;
        border-radius: 5px;
        border: 1px solid #e5e5e5;
        display: inline-block;
        font-size: 16px;
    }
</style>