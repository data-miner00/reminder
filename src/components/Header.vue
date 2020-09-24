<template>
  <header class="md-layout">
    <div
      class="md-layout-item md-xlarge-size-20 md-large-size-10 md-medium-hide"
    ></div>
    <div
      class="md-layout-item md-xlarge-size-60 md-large-size-80 md-medium-size-100 content"
    >
      <div class="left">
        <span class="md-display-1 logo">Reminder</span>
        <span class="on"><i>on</i></span>
        <span><Clock /></span>
      </div>
      <!-- <div class="center"></div> -->
      <div class="right">
        <div class="date">{{ todayDate }}</div>
        <md-avatar>
          <img
            src="https://img.icons8.com/plasticine/2x/google-logo.png"
            alt="avatar"
          />
        </md-avatar>
        <span class="md-body-1 md-layout-item md-small-hide">{{
          username
        }}</span>
        <md-button to="/" class="md-body-1 logout">Logout</md-button>
      </div>
    </div>
    <div
      class="md-layout-item md-xlarge-size-20 md-large-size-10 md-medium-hide"
    ></div>
  </header>
</template>

<script>
import Clock from "./Clock";
export default {
  data() {
    return {
      username: "Arkadian",
    };
  },
  components: {
    Clock,
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
};
</script>

<style lang="sass" scoped>
header
	position: fixed
	width: 100%
	display: flex
	flex: 1
  justify-content: space-between
	padding-top: 5px
	padding-bottom: 5px
	background-color: #E2AEDD
	z-index: 30
	box-shadow: 0 0 4px

.content
	display: flex
	flex: 1
	justify-content: space-between

.left
	display: flex
	align-items: center

.logo
	text-transform: uppercase
	color: white

.right
	display: flex

	align-items: center
	color: white
  width: 300px

.logout
	color: white

.on
	padding-left: 4px

.date
  margin-right: 20px
  font-size: 17px
  color: #745C97
  font-weight: bold
</style>
