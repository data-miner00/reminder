<template>
  <header>
		<div class="logo">Reminder</div>
		<input type="text" id="search" />
		<div class="bind-one">
			<div class="user">
				<img 
					src="https://img.icons8.com/plasticine/2x/google-logo.png" 
					width="30" 
					height="30" 
					class="avatar" 
				/>
				<div class="username">{{ username }}</div>
			</div>
			<div class="logout">Logout</div>
		</div>
	</header>
</template>

<script>
export default {
	data() {
		return {
			username: 'Arkadian',
		}
	}
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
		width: 13%
		display: flex
		justify-content: space-around
		align-items: center
		color: white
		.user
			display: flex
			align-items: center
			justify-content: space-between
			.username
				font-weight: bold
</style>