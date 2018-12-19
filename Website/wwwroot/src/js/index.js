import '../scss/global.scss'
import agility from 'agility'

document.getElementById('test').onclick = function() {
    alert('hello ' + agility.UniqueID('fromAgilityNPM-'));
}

//support hot module reloading ;)
if (module.hot) {
  module.hot.accept();
}