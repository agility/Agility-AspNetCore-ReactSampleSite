//load the shared dependancies between client and server (isomorphic components)
import './shared'

//load global styles
import './components/global.scss'

//register any client specific Agility Module react components (not SSR)
import UGCTestComponent from './components/ugc-test.jsx'

//pass them to ReactJS so they can keep track of it
global['Components']['UGCTestComponent'] = UGCTestComponent;

//support hot module reloading ;)
if (module.hot) {
    module.hot.accept();
  }
  
  