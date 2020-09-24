<template>
  <div class="dashboard">
    <Header />
    <div class="container">
      <div class="content">
        <div class="display-box">
          <div class="label">My Tasks <span class="count">(9)</span></div>
          <div class="button-group">
            <md-button>History</md-button>
            <md-button class="md-raised md-primary">Add Task</md-button>
          </div>
        </div>
        <div class="display-box2">
          <select name="category" id="category">
            <option value="all" selected>All</option>
            <option value="todos" selected>Todos</option>
            <option value="mustdos" selected>Mustdos</option>
            <option value="assignments" selected>Assignments</option>
            <option value="projects" selected>Projects</option>
          </select>
          <div class="search">
            <input
              type="text"
              class="searchTerm"
              placeholder="What are you looking for?"
            />
            <button type="submit" class="searchButton" title="Search">
              <i class="fa fa-search"></i>
            </button>
          </div>
        </div>
        <div class="results">
          <div class="task" v-for="task in tasks" :key="task.id">
            <div class="inner">
              <div>{{ task.title }}</div>
              <div
                class="elapsed"
                :style="task.fast ? 'color: crimson;' : 'color: green'"
              >
                {{ task.elapsed }}&nbsp;&nbsp;
                <span class="created">4th June</span>
              </div>
            </div>
          </div>
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
  computed: {},
  methods: {
    setSearch(e) {
      this.search = e.target.value;
    },
  },
  watch: {},
};
</script>

<style scoped>
@import url("https://fonts.googleapis.com/css2?family=Questrial&display=swap");

.container {
  padding: 100px 16%;
  display: flex;
  justify-content: center;
  flex-direction: column;
  align-items: center;
  background: rgb(255, 234, 254);
}

.content {
  width: 60%;
}

.results {
  margin: 20px 0 0 0;
  background: #f9e4ff;
  padding: 20px;
  border-radius: 8px;
}

.task {
  background-color: none;
  border-bottom: 3px solid #534b62;
  padding: 0 0 0 15px;
  margin: 5px 0;
  color: #534b62;
}
.created {
  font-size: 8px;
  color: gray;
}
.count {
  font-size: 16px;
  color: gray;
}
.inner {
  padding: 10px;
}

.display-box {
  display: flex;
  justify-content: space-between;
  align-items: center;
  margin: 20px 0;
  background: rgb(248, 205, 246);
  border-radius: 3px;
}

.display-box2 {
  display: flex;
  flex-direction: row;
  justify-content: space-between;
  align-items: center;
}
.label {
  padding: 0 0 0 8px;
  font-size: 24px;
}

.search {
  background: none;
}

.searchTerm {
  width: 400px;
  height: 40px;
  border: 3px solid #00b4cc;
  padding-left: 8px;
  border-radius: 10px 0 0 10px;
  outline: none;
  background-color: #bdf3fa;
  color: white;
}
.searchTerm::placeholder {
  color: #00b4cc;
}
.searchTerm:focus {
  color: #00b4cc;
}

.searchButton {
  height: 40px;
  width: 55px;
  padding-right: 5px;
  background: #00b4cc;
  border: none;
  cursor: pointer;
  border-radius: 0 10px 10px 0;
  color: white;
  transition: background-color 0.4s ease;
}
.searchButton:hover {
  background: rgba(0, 180, 204, 0.7);
}

#category {
  padding: 10px 16px;
  border: none;
  border-radius: 3px;
  font-size: 16px;
  outline-color: #f9e4ff;
  color: #000;
  background-color: #bdf3fa;
}
</style>
