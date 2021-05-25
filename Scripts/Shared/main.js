const app = new Vue({
    el: '#Layout',
    vuetify: new Vuetify(),
    data() {
        return {
            viewTabs: null,
            LanguageEn: true,
            Contact: [
                english = 'Contact me',
                spanish = 'Contáctame',
                tooltipEn = 'If you want to get in touch, click here.',
                tooltipEs = 'Si quieres ponerte en contacto, da click aquí.',
                icon = 'contact_mail'
            ],
            BookList: [
                english = 'Favorite book list',
                spanish = 'Lista de libros favoritos',
                tooltipEn = "Some of the best books I've read through my life.",
                tooltipEs = 'Algunos de los mejores libros que he leído en el transcurso de mi vida.',
                icon = 'menu_book'
            ],
            FAQ: [
                english = 'Frequently Asked Questions',
                spanish = 'Preguntas frecuentes',
                tooltipEn = 'Questions people asks me oftenly.',
                tooltipEs = 'Preguntas frecuentes.',
                icon = 'help_outline'
            ],
            Language: [
                english = 'Language',
                spanish = 'Lenguaje',
                tooltipEn = 'Change language to english.',
                tooltipEs = 'Cambiar idioma a español (Actualmente no disponible).',
                options =
                [
                    [
                        english = 'English',
                        spanish = 'Inglés',
                    ],
                    [
                        english = 'Spanish',
                        spanish = 'Español',
                    ]
                ],
                icon = 'language'
            ],

        }
    },
    methods: {
        LanguageToEn: function (event) {
            this.LanguageEn = true;
        },
        LanguageToEs: function (event) {
            this.LanguageEn = false;
        }
    }
})