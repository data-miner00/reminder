<template>
  <div id="app">
    <!-- <div id="nav">
      <router-link to="/">Home</router-link> |
      <router-link to="/about">About</router-link>
    </div>-->
    <router-view />
  </div>
</template>

<style lang="sass">

$color1: #1B1725
$color2: #534B62
$color3: #A499B3
$color4: #D0BCD5
$color5: #226CE0

*
  padding: 0
  margin: 0
  box-sizing: border-box

button
  border: none
  color: white
  padding: 15px 32px
  text-align: center
  text-decoration: none
  font-size: 16px
  margin: 4px 2px
  cursor: pointer
  background-color: $color5

#app
  display: flex
  flex: 1
  flex-direction: column
  height: 100vh
</style>
