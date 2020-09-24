<template>
  <form novalidate @submit.prevent="checkForm">
    <md-field md-clearable :class="emailError">
      <label>Email</label>
      <md-input v-model="email" />
      <span class="md-error">{{this.emailErrorMessage}}</span>
    </md-field>
    <md-field :class="passwordError">
      <label>Password</label>
      <md-input v-model="password" type="password" />
      <span class="md-helper-text">*Min: 8 Characters</span>
      <span class="md-error">{{this.passwordErrorMessage}}</span>
    </md-field>
    <md-field :class="confirmError">
      <label>Confirm</label>
      <md-input v-model="password" type="password" />
      <span class="md-error">{{this.confirmErrorMessage}}</span>
    </md-field>
    <div class="buttons">
      <md-button type="submit" class="md-raised md-primary">Register</md-button>
    </div>
  </form>
</template>

<script>
export default {
  data: () => ({
    email: "",
    password: "",
    confirm: "",
    emailErrorMessage: null,
    passwordErrorMessage: null,
    confirmErrorMessage: null,
  }),
  computed: {
    emailError() {
      return {
        "md-invalid": this.emailErrorMessage != null,
      };
    },
    passwordError() {
      return {
        "md-invalid": this.passwordErrorMessage != null,
      };
    },
    confirmError() {
      return {
        "md-invalid": this.confirmErrorMessage != null,
      };
    },
  },
  methods: {
    checkForm: () => {
      window.location.href = "/#/dashboard";
    },
  },
};
</script>

<style lang="sass" scoped>  
.buttons
  width: 100%
  text-align: center
</style>