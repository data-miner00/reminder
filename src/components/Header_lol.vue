<template>
  <div class="container">
    <li v-for="pg in pgl" v-bind:key=pg>{{ pg }}</li>
    <li v-for="(pg, index) in pgl" v-bind:key=index>{{ index + 1 }} - {{ pg }}</li>
    <input type="text" v-bind:value="randNo" />
    <input type="text" :value="randNo" />
    <input :value="inputValue" @keyup.space="processInput($event)" />
    <input :value="inputValue" @keyup.alt.enter="processInput($event)" />
  </div>
</template>

<script>
export default {
	data() {
    return {
      pgl: ['a', 'b', 'c', 'd', 'e'],
      randNo: 3,
    };
  },
  beforeCreate() {

  },
  created() {
    
  },
  beforeMount() {

  },
  mounted() {

  },
  beforeUnmount() {

  },
  unmounted() {

  },
  methods: {
    processInput(e) {
      e;
    }
  }
}
</script>

<style>

</style>