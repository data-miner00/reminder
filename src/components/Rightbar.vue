<template>
  <div class="rightbar">
		<h1>Add {{ selected === 'Assignment' ? 'an' : 'a' }} {{ selected }}!</h1>
		<h1>Advertisement</h1>
		<img src="" alt="" />
	</div>
</template>

<script>
export default {
	data() {
		return {
			selected: 'Mustdo'
		};
	}
}
</script>

<style lang="sass" scoped>
.rightbar
	background: purple
	width: 30%
</style>