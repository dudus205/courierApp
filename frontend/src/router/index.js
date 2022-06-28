import Vue from 'vue'
import VueRouter from 'vue-router'
import AppLogin from "@/views/AppLogin";
import DefaultLayout from "@/layouts/DefaultLayout";
import AppParcels from "@/views/AppParcels";
import AppHome from "@/views/AppHome";
import AppRegister from "@/views/AppRegister";
import AppScanner from "@/views/AppScanner";
import AppMap from "@/views/AppMap";

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
            redirect: "/login"
        }, {
            path: "/home",
            name: "home",
            component: AppHome
        }, {
            path: "/parcel",
            name: "parcel",
            component: AppParcels
        }, {
            path: "/scanner",
            name: "scanner",
            component: AppScanner
        }, {
            path: "/map",
            name: "map",
            component: AppMap
        }]
    }
]

const router = new VueRouter({
    mode: 'history',
    base: process.env.BASE_URL,
    routes
})

export default router
