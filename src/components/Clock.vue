<template>
  <div id="clock">{{ time }}</div>
</template>

<script>
export default {
  data() {
    return {
      time: new Date(),
    };
  },
  created() {
    
    (function() {
      setInterval(() => {
        this.currentTime();
      }, 1000);
    }.bind(this))();
  },
  methods: {
    currentTime() {
      var date = new Date(); /* creating object of Date class */
      var hour = date.getHours();
      var min = date.getMinutes();
      var sec = date.getSeconds();
      hour = this.updateTime(hour);
      min = this.updateTime(min);
      sec = this.updateTime(sec);
      this.time = hour + " : " + min + " : " + sec; /* adding time to the div */
    },
    updateTime(k) {
      if (k < 10) {
        return "0" + k;
      }
      else {
        return k;
      }
    }
  }
}
</script>

<style scoped>
/* Google font */
@import url('https://fonts.googleapis.com/css?family=Orbitron');

#clock {
  font-family: 'Orbitron', sans-serif;
  color: #66ff99;
  font-size: 56px;
  text-align: center;
  padding-top: 40px;
  padding-bottom: 40px;
}
</style>