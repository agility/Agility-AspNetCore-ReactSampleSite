//load the shared dependancies between client and server (isomorphic components)
import './shared'

//load global styles
import './components/_react-debug.scss'
import './components/_components.scss'
import './components/_reset.scss'
import './components/_media.scss'
import './components/_canvas.scss'
import './components/_fontface.scss'
import './components/_previewbar.scss'
import './components/_two-column-template.scss'

//register any client specific Agility Module react components (not SSR)
import UGCTestComponent from './components/ugc-test.jsx'

//pass them to ReactJS so they can keep track of it
global['Components']['UGCTestComponent'] = UGCTestComponent;

//support hot module reloading ;)
if (module.hot) {
    module.hot.accept();
}

