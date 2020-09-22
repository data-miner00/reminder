<template>
  <div class="dashboard">
		
		<div class="container">
			<h1 class="welcome">Welcome back {{ username }}!</h1>
			<h3 class="date">{{ todayDate }}</h3>
			<h3 class="md">My Tasks</h3>

			<div class="results">
				<div class="hr" />
				<div class="task" v-for="task in tasks" :key="task.id">
					<div class="inner">
						<div>{{ task.title }}</div>
						<div class="elapsed" style="color: red;">{{ task.elapsed }}</div>
					</div>
					<div class="hr" />
				</div>
			</div>
		</div>
		
  </div>
</template>

<script>

export default {
	name: 'Dashboard',
  data() {
		return {
			username: 'Arkadian',
			selected: 'Assignment',
			search: '',
			tasks: [
				{
					id: 1,
					title: 'Build software',
					elapsed: '5 days ago'
				},
				{
					id: 2,
					title: 'Research Plants',
					elapsed: '4 days ago'
				},
				{
					id: 3,
					title: 'Build Minecraft',
					elapsed: '3 days ago'
				},
				{
					id: 4,
					title: 'Study Quantum Physics',
					elapsed: '2 days ago'
				},
				{
					id: 5,
					title: 'Build Discord Bot Game',
					elapsed: '1 minutes ago'
				},
			]
		};
	},
	components: {

	},
	computed: {
		todayDate() {
			const MONTHS = ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December']
			var today = new Date();
			var dd = String(today.getDate()).padStart(2, '0');

			var ordinal;
			if (dd === '01' || dd === '11' || dd === '21' || dd === '31') ordinal = 'st';
			else if (dd === '02' || dd === '12' || dd === '22') ordinal = 'nd';
			else if (dd === '03' || dd === '13' || dd === '23') ordinal = 'rd';
			else ordinal = 'th';

			var mm = MONTHS[today.getMonth()]; //January is 0!
			var yyyy = today.getFullYear();

			today = dd + ordinal + ' ' + mm + ', ' + yyyy;

			return today;
		},
	},
	methods: {
		setSearch(e) {
			this.search = e.target.value;
		}
	},
	watch: {

	}
}
</script>

<style lang="sass" scoped>
@import url('https://fonts.googleapis.com/css2?family=Questrial&display=swap')
	

.container

	padding: 0 16%
	display: flex
	justify-content: center
	flex-direction: column
	align-items: center

	.welcome
		font-family: 'Questrial', sans-serif;
		padding: 20px
		text-align: center
		font-size: 2.3em


	.results
		width: 60%
		margin: 20px 0 0 0

.hr
	width: 100%
	height: 3px
	background: black

.inner
	padding: 20px

.date
	text-align: center
	font-size: 24px
	margin: 15px 0
</style>