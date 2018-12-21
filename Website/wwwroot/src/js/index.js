import '../scss/global.scss'
import agility from 'agility'

document.getElementById('test').onclick = function() {
    alert('hello ' + agility.UniqueID('fromAgilityNPM-'));
}

