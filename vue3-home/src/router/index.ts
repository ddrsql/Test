import { createRouter, createWebHistory } from 'vue-router'
import AppLayout from '@/components/layout/AppLayout.vue'
import AppPageWrapper from '@/components/layout/AppPageWrapper.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'applayout',
      redirect: '/home',
      component: AppLayout,
      children: [
        {
          // AppPageWrapper 将被渲染到 AppLayout 的 <routerview> 内部
          path: 'home',
          component: AppPageWrapper,
        },
        {
          path: 'about',
          component: () => import('../views/AboutView.vue')
        }
      ]
    },
    {
      path: '/about',
      name: 'about',
      // route level code-splitting
      // this generates a separate chunk (About.[hash].js) for this route
      // which is lazy-loaded when the route is visited.
      component: () => import('../views/AboutView.vue')
    }
  ]
})

export default router
