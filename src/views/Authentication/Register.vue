<template>
  <div class="md-layout parent">
    <div class="RightTopActions">
      <md-button to="login">Login</md-button>
    </div>
    <div
      class="md-layout-item md-xlarge-size-25 md-large-size-25 md-medium-size-30 md-small-size-50 md-xsmall-size-100 register"
    >
      <div class="description">
        <span class="md-headline">Welcome</span>
        <p class="md-body-1">blah blah blah...</p>
      </div>
      <RegisterForm />
    </div>
  </div>
</template>

<script>
import RegisterForm from "./RegisterForm";
export default {
  components: {
    RegisterForm,
  },
};
</script>

<style lang="sass" scoped>
.parent
  background: url("..\\..\\..\\sources\\images\\RegisterBackground.jpeg") no-repeat fixed
  background-position: center center
  background-size: cover
  display: flex
  flex: 1
  flex-direction: column
  justify-content: center
  align-items: flex-end
  padding: 20px

.RightTopActions
  position: absolute
  top: 20px
  right: 20px

.register
  padding: 40px 25px
  background-color: rgba(255, 255, 255, 0.75)
  border-radius: 5px
  flex: 0

.description
  align-items: flex-start

</style>