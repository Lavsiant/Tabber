import React from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import { getUser } from './userActions.jsx'
import Paper from '@material-ui/core/Paper';
import { userActions } from './userActions.jsx';

import "isomorphic-fetch";


class UserDetails extends React.Component {
    constructor() {
        super();
        this.state = {
            
        };
    }

    componentDidMount() {
        this.props.getUser(this.props.id);
        //  this.state.selectedTab =  this.props.tabs ? this.props.tabs[0] : null
    }

    render() {
     
        return (
            <Paper className='login'>
            <div className = 'root'>
                <div>Id = {this.props.user.id}</div>
                <div>Name = {this.props.user.username}</div>
              
            </div>
            </Paper>)
        }
}

let mapProps = (state) => {
    return {
        user: state.userDetailsReducer.user,
        error: state.userDetailsReducer.error
    }
}

let mapDispatch = (dispatch) => {
    return {
        getUser: bindActionCreators(userActions.getUser, dispatch),
    }
}

export default connect(mapProps, mapDispatch)(UserDetails) 