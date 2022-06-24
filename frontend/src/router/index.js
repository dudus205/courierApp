import Vue from 'vue'
import VueRouter from 'vue-router'
import AppLogin from "@/views/AppLogin";
import DefaultLayout from "@/layouts/DefaultLayout";
import AppParcels from "@/views/AppParcels";
import AppHome from "@/views/AppHome";
import AppRegister from "@/views/AppRegister";

Vue.use(VueRouter)

const routes = [
    {
        path: '/login',
        name: 'login',
        component: AppLogin,
    },
    {
        path: '/register',
        name: 'register',
        component: AppRegister,
    },
    {
        path: '/',
        component: DefaultLayout,
        children: [{
            path: "",
            redirect: "/home"
        }, {
            path: "/home",
            name: "home",
            component: AppHome
        }, {
            path: "/parcel",
            name: "parcel",
            component: AppParcels
        }]
    }
]

const router = new VueRouter({
    mode: 'history',
    base: process.env.BASE_URL,
    routes
})

export default router
