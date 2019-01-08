import React from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import { getCourse } from './courseActions.jsx'
import Paper from '@material-ui/core/Paper';

import "isomorphic-fetch";


class CourseDetails extends React.Component {
    constructor() {
        super();
        this.state = {
            
        };
    }

    componentDidMount() {
        this.props.getCourse(this.props.id);
        //  this.state.selectedcourse =  this.props.courses ? this.props.courses[0] : null
    }

    render() {
     
        return (
            <Paper className='login'>
            <div className = 'root'>
                <div>Id = {this.props.course.id}</div>
                <div>Name = {this.props.course.name}</div>
                <div>Description = {this.props.course.description}</div>
                <div>Creator = {this.props.course.creator}</div>
            </div>
            </Paper>)
        }
}

let mapProps = (state) => {
    return {
        course: state.courseReducer.course,
        error: state.courseReducer.error
    }
}

let mapDispatch = (dispatch) => {
    return {
        getCourse: bindActionCreators(getCourse, dispatch),
    }
}

export default connect(mapProps, mapDispatch)(CourseDetails) 