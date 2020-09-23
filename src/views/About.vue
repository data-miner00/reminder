<template>
  <div class="about">
    <Header />
    <h1>This is an about page</h1>
    <router-link to="/">Home</router-link>
  </div>
</template>

<script>
import Header from "../components/Header";
export default {
  components: {
    Header,
  },
};
</script>
