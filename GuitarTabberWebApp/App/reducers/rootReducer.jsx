import { combineReducers } from 'redux'
import tabsReducer from '../containers/tabs/tabsReducer.jsx'
import tabReducer from '../containers/tab/tabReducer.jsx'
import coursesReducer from '../containers/courses/coursesReducer.jsx'
import courseReducer from '../containers/course/courseReducer.jsx'
import registration from '../containers/user/registrationReducer.jsx'
import userDetailsReducer from '../containers/user/userDetailsReducer.jsx'
import authentication from '../containers/user/authenticationReducer.jsx'
import users from '../containers/user/userReducer.jsx'

export default combineReducers({
    tabsReducer,
    tabReducer,
    coursesReducer,
    courseReducer,
    registration,
    authentication,
    users,
    userDetailsReducer
})