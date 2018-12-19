//import style from '../css/site.css'
import style from '../scss/site.scss'

document.getElementById('test').onclick = function() {
    alert('hello tunc')
}

if (module.hot)
  module.hot.accept()