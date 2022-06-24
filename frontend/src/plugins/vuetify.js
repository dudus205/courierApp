import Vue from 'vue';
import Vuetify from 'vuetify/lib/framework';

Vue.use(Vuetify);


import Pl from 'vuetify/lib/locale/pl'

export default new Vuetify({
    lang: {
        locales: {Pl},
        current: 'Pl',
    },
});
