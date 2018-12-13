import React from 'react';
import ReactDOM from 'react-dom';
import { Route, Switch, Redirect } from 'react-router-dom';
import TabList from '../containers/tabs/tabList.jsx';
import About from '../containers/about/about.jsx';
import TabDetails from '../containers/tab/tabDetails.jsx';
import RegisterPage from '../containers/user/register.jsx';
import RequestTest from '../containers/test/testRequest.jsx';
import LoginPage from '../containers/user/login.jsx';
import CreateTab from '../containers/tab/tabCreate.jsx';


export default class Routing extends React.Component {

    render() {
        return (
            <main>
                <Switch>
                    <Route path="/about" component={About} />
                    <Route path="/tabs" component={TabList} />
                    <Route path="/register" component={RegisterPage} />
                    <Route path="/test" component={RequestTest} />
                    <Route path="/login" component={LoginPage} />
                    <Route path="/tab-create" component={CreateTab} />
                    <Route path="/tab/:id" render={(props) => <TabDetails id={props.match.params.id} {...props}/>} />
                    <Route exact path="/" render={() => (<Redirect to="/tabs" />)} />
                </Switch>
            </main>
        );
    }
};