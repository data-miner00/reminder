<template>
  <div class="home">
    <Header />
    <!-- <img alt="Vue logo" src="../assets/logo.png">
    <HelloWorld msg="Welcome to Your Vue.js App"/>-->
    <div class="logo-wrapper">
      <div id="logo">Reminder</div>
    </div>
    <div class="container">
      <button id="login">Login</button>
    </div>
    <router-link to="/">Home</router-link>
  </div>
</template>

<script>
// @ is an alias to /src
// import HelloWorld from '@/components/HelloWorld.vue'
import Header from "../components/Header";

export default {
  name: "Home",
  components: {
    Header,
  },
};
</script>

<style lang="sass" scoped>
.logo-wrapper
  height: 150px
  width: 100%
  background-color: #A499B3
  display: flex
  justify-content: center
  align-items: center

  #logo
    text-transform: uppercase
    letter-spacing: 3px
    font-size: 2em
    color: #1B1725

.container
  width: 100%
  height: 100vh
  background: #D0BCD5

  #login
    background-color: #226CE0
    color: white
    transition: all .3s ease
    border-radius: 5px

    &:hover
      background-color: white
      color: #226CE0
</style>