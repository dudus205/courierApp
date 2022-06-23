import Scanner from "@/components/Scanner";
import login from "@/components/login";
import qrcodeScanner from "@/components/qrcode-scanner";

export const routes = [
        {path: '', component: login, name: 'login'},
        {path: '/scanner', component: Scanner, name: 'scanner'},
        {path: '/qrcode-scanner', component: qrcodeScanner, name: 'qrcode-scanner'},
    ]
;
