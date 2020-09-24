<template>
  <div class="dashboard">
    <Header />
    <div class="container">
      <h3 class="date">{{ todayDate }}</h3>
      <div class="display-box">
        <div class="label">My tasks</div>
        <div class="button-group">
          <md-button>History</md-button>
          <md-button class="md-raised md-primary">Add Task</md-button>
        </div>
      </div>
      <div class="display-box2">
        <div class="search">
          <input type="text" class="searchTerm" placeholder="What are you looking for?" />
          <button type="submit" class="searchButton">
            <i class="fa fa-search"></i>
          </button>
        </div>
      </div>
      <div class="results">
        <!-- <div class="hr" /> -->
        <div class="task" v-for="task in tasks" :key="task.id">
          <div class="inner">
            <div>{{ task.title }}</div>
            <div class="elapsed" style="color: red;">{{ task.elapsed }}</div>
          </div>
          <!-- <div class="hr" /> -->
        </div>
      </div>
    </div>
    <Footer />
  </div>
</template>

<script>
import Header from "../components/Header";
import Footer from "../components/Footer";
import tasks from "../assets/dummy";
export default {
  name: "Dashboard",
  data() {
    return {
      search: "",
      tasks,
    };
  },
  components: {
    Header,
    Footer,
  },
  mounted() {
    let fontAwesome = document.createElement("script");
    fontAwesome.setAttribute(
      "src",
      "https://kit.fontawesome.com/047746317e.js"
    );
    document.head.appendChild(fontAwesome);
  },
  computed: {
    todayDate() {
      const MONTHS = [
        "January",
        "February",
        "March",
        "April",
        "May",
        "June",
        "July",
        "August",
        "September",
        "October",
        "November",
        "December",
      ];
      var today = new Date();
      var dd = String(today.getDate()).padStart(2, "0");

      var ordinal;
      if (dd === "01" || dd === "11" || dd === "21" || dd === "31")
        ordinal = "st";
      else if (dd === "02" || dd === "12" || dd === "22") ordinal = "nd";
      else if (dd === "03" || dd === "13" || dd === "23") ordinal = "rd";
      else ordinal = "th";

      var mm = MONTHS[today.getMonth()]; //January is 0!
      var yyyy = today.getFullYear();

      today = dd + ordinal + " " + mm + ", " + yyyy;

      return today;
    },
  },
  methods: {
    setSearch(e) {
      this.search = e.target.value;
    },
  },
  watch: {},
};
</script>

<style lang="sass" scoped>
@import url('https://fonts.googleapis.com/css2?family=Questrial&display=swap')
	

.container

	padding: 40px 16% 100px
	display: flex
	justify-content: center
	flex-direction: column
	align-items: center
	background: #C1CFDA

	.welcome
		font-family: 'Questrial', sans-serif;
		padding: 20px
		text-align: center
		font-size: 2.3em


	.results
		width: 60%
		margin: 20px 0 0 0
		background: none

		.task
			background-color: none
			border-bottom: 3px solid #534B62
			padding: 0 0 0 15px
			margin: 5px 0
			color: #534B62

.hr
	width: 75%
	height: 3px
	border-radius: 5px
	background: gray
	margin: 0 auto

.inner
	padding: 10px

.date
	text-align: center
	font-size: 28px
	margin: 15px 0 55px



.display-box
	display: flex
	justify-content: space-between
	align-items: center
	width: 600px
	margin: 20px 0
	background: rgba(0,0,0,0.2)

	.label
		padding: 0 0 0 8px
		font-size: 24px


.search
	.searchTerm
		width: 350px
		height: 35px
		border: 3px solid #00B4CC
		padding-left: 8px
		border-radius: 10px 0 0 10px
		outline: none
		&:focus
			color: #00B4CC;
	.searchButton
		height: 35px
		width: 55px
		padding-right: 5px
		background: #00B4CC
		border: none
		cursor: pointer
		border-radius: 0 10px 10px 0
		color: white
</style>