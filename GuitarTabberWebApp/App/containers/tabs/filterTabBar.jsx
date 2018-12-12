import React from 'react';
import ReactDOM from 'react-dom';
import TextField from '@material-ui/core/TextField';

export default class FilterTabBar extends React.Component {
    constructor() {
        super();
        this.state = {
            name: '',
            minTempo: '',
            maxTempo: ''
        };
    }

    onNameChanged = e => {
       
        this.setState({ name: e.target.value });
        this.state.name = e.target.value;
        this.props.filterTabs({name: e.target.value, maxTempo: this.state.maxTempo, minTempo: this.state.minTempo});
    }

    onMinTempoChanged = e => {
        this.setState({ minTempo: e.target.value });
        this.props.filterTabs({name: this.state.name, maxTempo: this.state.maxTempo, minTempo: e.target.value});
    }

    onMaxTempoChanged = e => {
        this.setState({ maxTempo: e.target.value });
        this.props.filterTabs({name: this.state.name, maxTempo: e.target.value, minTempo: this.state.minTempo});
    }

    render() {
        return (
            <div className="filter-bar">
                <TextField 
                    className="filter-field"
                    label="Tab name"
                    margin="normal"
                    onChange={this.onNameChanged}
                />
                <TextField                   
                    label="Min tempo"
                    defaultValue=""
                    type="number"
                    className="filter-field"
                    margin="normal"
                    onChange={this.onMinTempoChanged}
                />
                <TextField
                    className="filter-field"
                    label="Max tempo"
                    type="number"
                    margin="normal"
                    onChange={this.onMaxTempoChanged}
                />
            </div>
        );
    }
}