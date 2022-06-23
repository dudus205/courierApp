<template>
        <div id="content">
            <h1><b>Portfolio</b></h1>
            <div v-if="portfolio.length > 0">
                <li id="card" v-for="stock in portfolio" :key="stock.id">
                    <b>{{stock.name}}</b>
                    <div class="value">
                        <p>Sell: {{stock.sell}} | You have: {{stock.amount}}</p>
                    </div>
                    <hr>
                    <label>
                        <p>Amount:</p>
                        <input type="number" :id="stock.id" min="1" :max="stock.amount">
                    </label>
                    <button @click="sell(stock.id)">Sell!</button>
                </li>
            </div>
            <div v-else>
                <h2>Your portfolio is empty.</h2>
                <hr>
                <router-link tag="a" to="/stocks">Get some actions here!</router-link>
            </div>
    </div>
</template>

<script>
    export default {
        name: "Portfolio",
        data (){
            return{
                stocks: [],
                portfolio: [],
                money: 0,
            }
        },
        mounted: function(){
            this.portfolio = this.$store.getters.getPortfolio;
            this.stocks = this.$store.getters.getStocks;
            this.money = this.$store.getters.getMoney;
        },
        methods: {
            sell(id){
                let amount = parseInt(document.getElementById(id).value);
                let value = 0;
                for(let i=0; i < this.portfolio.length; i++)
                    if(this.portfolio[i].id === id){
                        value = amount * this.portfolio[i].sell;
                        if(this.portfolio[i].amount === amount)
                            this.portfolio.splice(i,1);
                        else
                            this.portfolio[i].amount -= amount;
                        break;
                    }
                this.money += value;
                this.$store.state.portfolio = this.portfolio;
                this.$store.state.money = this.money;
                document.getElementById(id).value = "";
            }
        }
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
        text-align: center;
        box-shadow: 0 0 3px 1px #e5e5e5;
    }
    a{
        color: black;
        text-decoration: none;
    }
    a:hover{
        color: #fca311;
    }
    ul, li {
        margin: 0;
        padding: 0;
        display: inline-block;
        text-align: left;
        float:left;
    }
    li {
        width: calc(50% - 38px);
        padding: 10px;
        margin: 7px;
        background-color: #e5e5e5;
        border-radius: 5px;
        border: 1px solid #14213d;
        box-shadow: 2px 2px 5px 0 #000;
    }
    .value{
        float: right;
        text-align: left;
        font-size: 13px;
        margin-left: 10px;
    }
    hr{
        margin: 10px 0 15px 0;
    }
    button{
        background-color: #14213d;
        border: 1px solid #14213d;
        color: #e5e5e5;
        opacity: 0.9;
        font-size: 17px;
        border-radius: 3px;
        margin: 0 10px;
        padding: 3px 5px;
    }
    button:hover{
        opacity: 1;
        transition: opacity 0.2s ease-in-out;
    }
    button:active{
        transform: translateY(2px);
    }
    p{
        font-size: 13px;
        margin: 2px 0;
        padding: 0;
    }
</style>
