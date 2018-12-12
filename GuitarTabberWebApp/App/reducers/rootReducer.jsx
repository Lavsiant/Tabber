import { combineReducers } from 'redux'
import tabsReducer from '../containers/tabs/tabsReducer.jsx'
import tabReducer from '../containers/tab/tabReducer.jsx'
import registration from '../containers/user/registrationReducer.jsx'
import authentication from '../containers/user/authenticationReducer.jsx'
import users from '../containers/user/userReducer.jsx'

export default combineReducers({
    tabsReducer,
    tabReducer,
    registration,
    authentication,
    users
})