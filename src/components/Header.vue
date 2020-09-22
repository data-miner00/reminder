<template>
  <header>
		<div class="logo">Reminder</div>
		<input type="text" name="search" id="search" v-model="search" />
		<div class="bind-one">
		
		</div>
	</header>
</template>

<script>
export default {

}
</script>

<style lang="sass" scoped>
header
	display: flex
	flex-direction: row
	height: 60px
	width: 100%
	background-color: #1B1725
	justify-content: space-around
	align-items: center

	.logo
		text-transform: uppercase
		letter-spacing: 2px
		font-size: 2em
		color: white

	#search
		width: 30%
		height: 35px

	.bind-one
		height: 35px
		width: 20%
		background-color: blue
</style>