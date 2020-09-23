<template>
  <div class="parent">
    <div class="RightTopActions">
      <md-button to="Register" class="md-primary">Register</md-button>
    </div>
    <div>
      <md-icon class="md-size-5x">assignment</md-icon>
      <span class="md-display-1">Reminder</span>
    </div>
    <LoginForm />
  </div>
</template>

<script>
import LoginForm from "./LoginForm";
export default {
  components: {
    LoginForm,
  },
};
</script>

<style lang="sass" scoped>
.parent
  background: url("..\\..\\..\\sources\\images\\LoginBackground.jpg") no-repeat fixed
  background-position: center center
  background-size: cover
  display: flex
  flex: 1
  flex-direction: column
  justify-content: center
  align-items: center
  padding: 20px

.RightTopActions
  position: absolute
  top: 20px
  right: 20px
</style>