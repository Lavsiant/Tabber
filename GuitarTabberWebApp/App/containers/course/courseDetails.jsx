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
        let language = '';
        if (localStorage.getItem('lang')) {
            language = localStorage.getItem('lang');
        }
        else {
            language = 'en';
            localStorage.setItem('lang', 'en');
        }
        if (language == 'en') {
            switch (x) {
                case 1: return 'Acoustic Guitar';
                case 2: return 'Electric Guitar';
                case 3: return 'Classical Guitar';
            }
        }
        else{
            switch (x) {
                case 1: return 'Акустична гітара';
                case 2: return 'Електрогітара';
                case 3: return 'Класична гітара';
            }
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
        let language = '';
        if(localStorage.getItem('lang')){
            language = localStorage.getItem('lang');
        }
        else{
            language = 'en';
            localStorage.setItem('lang', 'en');
        }
        return (
            <Paper className='tab-create' style={{ fontSize: 20, marginTop: 200 }} >
                <div style={{ textAlign: 'center', display: 'block' }}>
                    <div>
                    <FormLabel style={{ fontSize: 22 }}>{language == 'en' ? 'Course name' : 'Назва курсу'} </FormLabel>
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
                    <div style={{ marginTop: 30 }}></div>
                    <div style = {{margin:'auto'}}>
                        <FormLabel style={{ fontSize: 22, marginTop: 80 }}>{language == 'en' ? 'Description' : 'Опис'} </FormLabel>  <br />
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
                        <FormLabel style={{ fontSize: 22, marginTop: 80 }}>{language == 'en' ?  'Type' : 'Тип'}</FormLabel>
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
                    <FormLabel style={{ fontSize: 22, marginTop: 80 }}>{language == 'en' ? 'Lessons' : 'Вправи'}</FormLabel>
                    {this.state.course.lessons.map(lesson => {
                            return (
                                <ExpansionPanel style={{ width: '85%', margin: 'auto', marginBop: '15' }}>
                                    <ExpansionPanelSummary expandIcon={<ExpandMoreIcon />}>
                                        <Typography >{lesson.name}</Typography>
                                    </ExpansionPanelSummary>
                                    <ExpansionPanelDetails>
                                        <Typography style={{ fontSize: 18 }}>
                                            <i>{language == 'en' ? 'Lesson name' : 'Назва вправи'}:</i> {lesson.name}  &nbsp;&nbsp;&nbsp;   <i>{language == 'en' ? 'Repeat times' : 'Кількість повторювань'} : {lesson.repeatNumber}</i>  &nbsp;&nbsp;&nbsp;    <i>{language == 'en' ? 'Start bpm' : 'Початковий темп'}:</i> {lesson.startBpm}  &nbsp;&nbsp;&nbsp;   <i>{language == 'en' ? 'Default step' : 'Рекомендований шаг'}: </i> {lesson.minTempoStep}
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
                    <Button size="large" variant="contained" color="primary" type='button' onClick={this.handleSubscribe} style={{ margin: 15 }}>{language == 'en' ? 'Subscribe' : 'Добавити'}</Button>



                </div>
            </Paper>)
    }
}

