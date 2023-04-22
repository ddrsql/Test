import { createApp } from 'vue'
import { createPinia } from 'pinia'

import App from './App.vue'
import router from './router'

//初始自带
// import './assets/main.css'
//tabler
// import './assets/tabler.min.css'
//import './assets/tabler.min.js'
import './assets/tabler.css'
import './assets/tabler.js'

//bootstrap
// import 'bootstrap/dist/css/bootstrap.css'
// import 'bootstrap/dist/js/bootstrap.bundle.js'
//bootstrap-vue-next
// import 'bootstrap-vue-next/dist/bootstrap-vue-next.css'

const app = createApp(App)

app.use(createPinia())
app.use(router)

app.mount('#app')
