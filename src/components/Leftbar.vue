<template>
  <div class="sidebar">
		<Clock />
		<h1>Category</h1>
		<div class="links">
			<button>All</button>
			<button>Assignments</button>
			<button>Todos</button>
			<button>Mustdos</button>
			<button>Projects</button>
		</div>
	</div>
</template>

<script>
import Clock from './Clock'
export default {
	components: {
		Clock,
	}
}
</script>

<style lang="sass" scoped>
.sidebar
	width: 26%
	background-color: #534B62
	height: 100vh
	display: flex
	flex-direction: column
	padding: 30px 10px 0
	align-items: center
	justify-content: flex-start
</style>