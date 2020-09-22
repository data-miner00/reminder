<template>
  <div class="dashboard">
		<header>
			<div class="logo">Reminder</div>
			<input type="text" name="search" id="search" v-model="search" />
			<div class="bind-one">
			
			</div>
		</header>
		<div class="container">
			<Leftbar />
			<div class="content">
				<div class="center">
					<h1 class="welcome">Welcome back {{ username }}!</h1>
					<h3>It is {{ todayDate }}</h3>
					<h3>My tasks...</h3>
					<div class="results">
						
						<hr />
						<div class="resultsr" v-for="task in tasks" :key="task.id">
							<div>{{ task.title }}</div>
							<div class="elapsed" style="color: red;">{{ task.elapsed }}</div>
							<hr />
						</div>
					</div>
				</div>
				<Rightbar />
			</div>
		</div>
		
  </div>
</template>

<script>
import Leftbar from '../components/Leftbar'
import Rightbar from '../components/Rightbar'

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
					elapsed: '5 days'
				},
				{
					id: 2,
					title: 'Research Plants',
					elapsed: '4 days'
				},
				{
					id: 3,
					title: 'Build Minecraft',
					elapsed: '3 days'
				},
				{
					id: 4,
					title: 'Study Quantum Physics',
					elapsed: '2 days'
				},
				{
					id: 5,
					title: 'Build Discord Bot Game',
					elapsed: '1 minutes'
				},
			]
		};
	},
	components: {
		Leftbar,
		Rightbar,
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

.container

	display: flex
  flex-wrap: wrap


	.content
		background: #D0BCD5
		width: 74%
		display: flex
		flex-direction: row
		flex-wrap: wrap

		.center

			width: 70%
			background: green
    
			.welcome
				font-family: 'Questrial', sans-serif;
				padding: 20px
				text-align: center
				font-size: 2.3em

			.results
				width: 80%
				height: 500px
				background: blue


</style>