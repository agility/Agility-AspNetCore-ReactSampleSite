import '../_shared'
import './_global.scss'
import UGCTestComponent from './ugc-test.jsx'

global['Components']['UGCTestComponent'] = UGCTestComponent;

//support hot module reloading ;)
if (module.hot) {
    module.hot.accept();
  }
  
  