<template>
  <div id="clock">{{ time }}</div>
</template>

<script>
export default {
  data() {
    return {
      time: new Date().toLocaleTimeString('en-US'),
    };
  },
  created() {
    
    (function() {
      setInterval(() => {
        this.time = this.currentTime();
      }, 1000);
    }.bind(this))();
  },
  methods: {
    currentTime() {
      return new Date().toLocaleTimeString('en-US');
    },
  }
}
</script>

<style scoped>
/* Google font */
@import url('https://fonts.googleapis.com/css?family=Orbitron');

#clock {
  font-family: 'Orbitron', sans-serif;
  color: #66ff99;
  font-size: 26px;
  text-align: center;
  width: 180px;
}
</style>