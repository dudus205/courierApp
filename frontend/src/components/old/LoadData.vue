<template>
    <div id="content">
        <h1>You now have:</h1>
        <p>Money: {{getMoney}}</p>
        <div class="block">
            <p>Stocks:</p>
            <ul v-for="stock in stocks" :key="stock.name">
                <li>
                    <p>{{stock.name}}</p>
                    Buy: {{stock.buy}}  Sell: {{stock.sell}}
                </li>
            </ul>
        </div>
        <div class="block">
            <div v-if="portfolio.length === 0">
                <p>Your portfolio is empty.</p>
                <router-link tag="a" to="/stocks">Get some actions here!</router-link>
            </div>
            <div v-else>
                <p>Portfolio:</p>
                <ul v-for="item in portfolio" :key="item.name">
                    <li>
                        <p>{{item.name}}</p>
                        Amount: {{item.amount}}  Sell: {{item.sell}}
                    </li>
                </ul>
            </div>
        </div>

    </div>
</template>

<script>
    export default {
        name: "LoadData",
        computed: {
            getMoney () {
                return this.$store.getters.getMoney;
            }
        },
        data (){
            return{
                stocks: [],
                portfolio: [],
            }
        },
        mounted: function(){
            this.portfolio = this.$store.getters.getPortfolio;
            this.stocks = this.$store.getters.getStocks;
        },
    }
</script>

<style scoped>
    #content{
        background-color: #ffffff;
        color: #000;
        width: calc(100% - 20px);
        padding: 10px 15px;
        margin: 15px auto;
        border-radius: 5px;
        border: 1px solid #e5e5e5;
        display: inline-block;
        font-size: 16px;
        text-align: left;
        box-shadow: 0 0 3px 1px #e5e5e5;
    }
    p{
        font-weight: bold;
    }
    h1{
        margin-left: 0;
    }
    .block{
        display: inline-grid;
        width: 50%;
        padding: auto;
    }
    a{
        text-decoration: none;
        color: #14213d;
    }
    a:hover{
        color: #fca311;
    }

    ul,li{
        margin: 0 0 4px 15px;
        padding: 0;
    }
    ul p{
        margin-bottom: 5px;
    }
</style>
