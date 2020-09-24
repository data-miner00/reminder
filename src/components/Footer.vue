<template>
  <footer>
    <div class="word">
      Made with
      <span title="love" class="love">❤</span> &copy; 2020 Weiyan Holdings
    </div>
  </footer>
</template>

<script>
export default {};
</script>

<style lang="sass" scoped>
@import url('https://fonts.googleapis.com/css?family=Poppins&display=swap')

footer
    height: 60px
    width: 100%
    background: #e090d8
    display: flex
    justify-content: center
    align-items: center

    .word
        font-size: 15px
        font-family: 'Poppins', cursive
        color: white

        .love
            color: red
</style>
