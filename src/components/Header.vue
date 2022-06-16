<template>
  <div id="container">
    <header id="left">
      <ul>
          <router-link tag="li" to="/scanner">Scanner</router-link>
      </ul>
    </header>
  </div>
</template>

<script>
export default {
  name: 'Header'
}
</script>


<style scoped>
  p{
    margin: 0;
    padding: 0;
    display: inline-block;
  }
  #container{
    background-color: #e5e5e5;
    color: #000;
    width: 100%;
    padding: 2px 5px;
    margin: 0;
    border-radius: 5px;
    border: 1px solid #e5e5e5;
    display: inline-block;
    font-size: 18px;
    box-shadow: 0 0 3px 1px #e5e5e5;
  }
  #left{
    float: left;
    width: 48%;
  }
  #right{
    float: right;
    text-align: right;
    width: 48%;
  }
  ul, li{
    text-decoration: none;
    display: inline-block;
    margin: 0;
    padding: 0;
  }
  li{
    padding: 6px 12px;
  }
  li:hover, li:active {
    color: #fca311;
    cursor: pointer;
  }
  .yellow{
      color: #fca311;
      cursor: default;
      background-color: #fff;
      border-radius: 5px;
      border: 2px solid #fff;
      padding-left: 20px;
      margin: -2px -5px -2px -10px;
      clip-path: polygon(10% 0, 100% 0, 100% 100%, 4% 100%);
  }
  .yellow:hover{
    cursor: default;
  }
  .arrow{
    margin-bottom: -3px;
    width: 18px;
    height: 18px;
    display: inline-block;
  }
  .dropdown-content {
    background-color: #e5e5e5;
    position: absolute;
    z-index: 1;
    margin: 7px 0 0 4px;
    color: #000000;
  }
  .dropdown-content li{
    background-color: #e5e5e5;
    display: block;
    text-align: left;
    padding: 7px;
    border-radius: 5px;
    border: 1px solid #e5e5e5;
    font-size: 18px;
    box-shadow: 0 0 3px 1px #e5e5e5;
    width: 70px;
  }
  .dropdown-content li:hover{
    background-color: #fff;
    color: #14213d;
  }

</style>
