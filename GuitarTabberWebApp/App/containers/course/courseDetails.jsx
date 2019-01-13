import React from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import { getCourse } from './courseActions.jsx'
import Paper from '@material-ui/core/Paper';

import "isomorphic-fetch";
import { FormLabel } from '@material-ui/core';
import TextField from '@material-ui/core/TextField';
import ExpansionPanel from '@material-ui/core/ExpansionPanel';
import ExpansionPanelSummary from '@material-ui/core/ExpansionPanelSummary';
import ExpansionPanelDetails from '@material-ui/core/ExpansionPanelDetails';
import Typography from '@material-ui/core/Typography';
import NoSsr from '@material-ui/core/NoSsr';
import ExpandMoreIcon from '@material-ui/icons/ExpandMore';
import Button from '@material-ui/core/Button';


export default class CourseDetails extends React.Component {
    constructor() {
        super();
        this.state = {
            course: {
                lessons: []
            }
        };
    }

    componentDidMount() {
        this.getCourse(this.props.id).then((data) => {
            this.setState({ course: data });
        });
    }

    getCourse = (id) => {
        const url = 'api/Course/course?id=' + id;

        return fetch(url)
            .then((response) => response.json());
    }

    getTypeString = (x) => {
        switch (x) {
            case 1: return 'Acoustic Guitar';
            case 2: return 'Electric Guitar';
            case 3: return 'Classical Guitar';
        }
    }

    handleSubscribe = () =>{
        let usern='';

        if (localStorage.getItem('user')) {
            usern = JSON.parse(localStorage.getItem('user')).username;
            const url = 'api/Course/course-add?id=' + this.props.id + '&username=' + usern;
            return fetch(url)
            .then((response) => { window.location = config.apiUrl + "/courses";
                return response.json();});
           
        }
        else {
            window.location = config.apiUrl + "/login";
            
        }

      
    }

    render() {

        return (
            <Paper className='tab-create' style={{ fontSize: 20, marginTop: 200 }} >
                <div style={{ textAlign: 'center', display: 'block' }}>
                    <div>
                    <FormLabel style={{ fontSize: 22 }}>Course name </FormLabel>
                    <TextField
                        style={{ width: '85%' }}
                        id="outlined-read-only-input"
                        value={this.state.course.name}
                        defaultValue="Hello World"
                        margin="normal"
                        InputProps={{
                            readOnly: true,
                        }}
                        variant="outlined"
                    />
                    </div>
                    <br />
                    <div style={{ marginTop: 30 }}>
                        <FormLabel style={{ fontSize: 22, marginTop: 80 }}>Description </FormLabel>
                        <TextField
                            style={{  width: '85%' }}
                            id="outlined-read-only-input"
                            value={this.state.course.description}
                            defaultValue="Default decription"
                            margin="normal"
                            InputProps={{
                                readOnly: true,
                            }}
                            variant="outlined"
                        />
                    </div>
                    <br/>
                    <div style={{ marginTop: 30, marginBottom: 30 }}>
                        <FormLabel style={{ fontSize: 22, marginTop: 80 }}>Type</FormLabel>
                        <br/>
                        <TextField
                            style={{ width: '85%' }}
                            id="outlined-read-only-input"
                            value={this.getTypeString(this.state.course.type)}
                            defaultValue="Hello World"
                            margin="normal"
                            InputProps={{
                                readOnly: true,
                            }}
                            variant="outlined"
                        />
                    </div>
                    <FormLabel style={{ fontSize: 22, marginTop: 80 }}>Lessons</FormLabel>
                    {this.state.course.lessons.map(lesson => {
                            return (
                                <ExpansionPanel style={{ width: '85%', margin: 'auto', marginBop: '15' }}>
                                    <ExpansionPanelSummary expandIcon={<ExpandMoreIcon />}>
                                        <Typography >{lesson.name}</Typography>
                                    </ExpansionPanelSummary>
                                    <ExpansionPanelDetails>
                                        <Typography style={{ fontSize: 18 }}>
                                            <i>Lesson name:</i> {lesson.name}  &nbsp;&nbsp;&nbsp;   <i>Repeat times: {lesson.repeatNumber}</i>  &nbsp;&nbsp;&nbsp;    <i>Start bpm:</i> {lesson.startBpm}  &nbsp;&nbsp;&nbsp;   <i>Default step: </i> {lesson.minTempoStep}
                                        </Typography>
                                    </ExpansionPanelDetails>
                                </ExpansionPanel>
                                // <Paper className='root' style={{textAlign:'left', width:'max-content', margin:'auto' ,marginBottom:20}}>
                                //     <label>Lesson name: {lesson.name} </label>
                                //     <label>Repeat: {lesson.name} </label>
                                //     <label>Start Bpm: {lesson.startBpm} </label>
                                //     <label>Step Bpm: {lesson.stepBpm} </label>

                                //     <Button type='button' onClick={() => this.handleRemoveIterationClickButton(counter)} style={{ marginLeft: 5 }}>Remove</Button>
                                // </Paper>
                            );
                        })}
                    <br/>
                    <Button size="large" variant="contained" color="primary" type='button' onClick={this.handleSubscribe} style={{ margin: 15 }}>Subscribe</Button>



                </div>
            </Paper>)
    }
}

