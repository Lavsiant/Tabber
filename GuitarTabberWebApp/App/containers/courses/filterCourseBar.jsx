import React from 'react';
import ReactDOM from 'react-dom';
import TextField from '@material-ui/core/TextField';

export default class FilterCourseBar extends React.Component {
    constructor() {
        super();
        this.state = {
            name: '',
        };
    }

    onNameChanged = e => {
       
        this.setState({ name: e.target.value });
        this.state.name = e.target.value;
        this.props.filterTabs({name: e.target.value});
    }

    // onMinTempoChanged = e => {
    //     this.setState({ minTempo: e.target.value });
    //     this.props.filterTabs({name: this.state.name, maxTempo: this.state.maxTempo, minTempo: e.target.value});
    // }

    // onMaxTempoChanged = e => {
    //     this.setState({ maxTempo: e.target.value });
    //     this.props.filterTabs({name: this.state.name, maxTempo: e.target.value, minTempo: this.state.minTempo});
    // }

    render() {
        return (
            <div className="filter-bar">
                <div className="filter">
                    <TextField 
                        className="filter-field"
                        label="Course name"
                        margin="normal"
                        onChange={this.onNameChanged}
                    />
                </div>
                {/* <div className="filter">
                    <TextField                   
                        label="Min tempo"
                        defaultValue=""
                        type="number"
                        className="filter-field"
                        margin="normal"
                        onChange={this.onMinTempoChanged}
                    />
                </div>
                <div className="filter">
                    <TextField
                        className="filter-field"
                        label="Max tempo"
                        type="number"
                        margin="normal"
                        onChange={this.onMaxTempoChanged}
                    />
                </div> */}
            </div>
        );
    }
}