import Vue from 'vue'
import VueRouter from 'vue-router'
import AppLogin from "@/views/AppLogin";
import DefaultLayout from "@/layouts/DefaultLayout";
import AppMap from "@/views/AppMap";
import AppScanner from "@/views/AppScanner";
import AppParcels from "@/views/AppParcels";
import AppHome from "@/views/AppHome";

Vue.use(VueRouter)

const routes = [
    {
        path: '/login',
        name: 'login',
        component: AppLogin,
    },
    {
        path: '/',
        component: DefaultLayout,
        children: [{
            path: "",
            redirect: "/home"
        }, {
            path: "/home",
            component: AppHome
        }, {
            path: "/map",
            component: AppMap
        }, {
            path: "/scanner",
            component: AppScanner
        }, {
            path: "/parcel",
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
