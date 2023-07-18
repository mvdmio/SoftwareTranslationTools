/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["**/*.razor"],
  theme: {
    extend: {},
  },
  plugins: [
    require('@tailwindcss/forms'),
    require('@tailwindcss/typography'),
  ],
}
