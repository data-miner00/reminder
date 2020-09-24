<template>
  <header class="md-layout">
    <div class="md-layout-item md-xlarge-size-20 md-large-size-10 md-medium-hide"></div>
    <div class="md-layout-item md-xlarge-size-60 md-large-size-80 md-medium-size-100 content">
      <div class="left">
        <span class="md-display-1 logo">Reminder</span>
      </div>
      <div class="center">
        <input type="text" id="search" />
      </div>
      <div class="right">
        <md-avatar>
          <img src="https://img.icons8.com/plasticine/2x/google-logo.png" alt="avatar" />
        </md-avatar>
        <span class="md-body-1 md-layout-item md-small-hide">{{username}}</span>
        <md-button to="login" class="md-body-1 logout">Logout</md-button>
      </div>
    </div>
    <div class="md-layout-item md-xlarge-size-20 md-large-size-10 md-medium-hide"></div>
  </header>
</template>

<script>
export default {
  data() {
    return {
      username: "Arkadian",
    };
  },
};
</script>

<style lang="sass" scoped>
header
	position: fixed
	width: 100%
	display: flex
	flex: 1
	padding-top: 5px
	padding-bottom: 5px
	background-color: #1B1725

.content
	display: flex
	flex: 1
	justify-content: space-between

.left
	display: flex
	flex: 1
	align-items: center

.logo
	text-transform: uppercase
	color: white

.center
	display: flex
	flex: 3
	justify-content: center
	align-items: center

#search
	width: 80%
	height: 35px
	padding-left: 10px
	padding-right: 10px
	border-radius: 5px

.right
	display: flex
	flex: 1
	align-items: center
	color: white

.logout
	color: white
</style>