import React, {useEffect, useState, Component} from 'react';
import {Box, Button} from "@mui/material"
import { DataGrid } from '@mui/x-data-grid';
import '../index.css'
import '../css/style.css'
import DeleteData from './DeleteData'
import Cookies from 'universal-cookie'
import { green, pink } from '@mui/material/colors';
import Avatar from '@mui/material/Avatar';
import Stack from '@mui/material/Stack';
import PageviewIcon from '@mui/icons-material/Pageview';
import Pay from './EditPayment'
import { useNavigate } from 'react-router'


const cookies = new Cookies();

const Payment = (props) => {

    const payments = props.payments
    const deleteRegister = props.deleteRegister
    const updateRegister = props.updateRegister
    const navigate = useNavigate()
    const paymentsOnly = payments.filter(item => item.ownerCard === cookies.get('cardIdentification') && item.payState === 'pending')
    const [paymentsaux, setPaymentsaux] = React.useState([]) //dates dinamycs
    const [tablapayments, setTablapayments] = React.useState([])
    const [search, setSearch] = React.useState()


    const handleDeleteRegister = (id) => {
        deleteRegister(id)
    }

    const habldeUpdateRegister = (values) => {
        updateRegister(values)
    }

    const columns = [
        { field: 'paymentPayCode', headerName: 'Pay Code', width: 150 },
        { field: 'paymentOwnerName', headerName: 'Owner Name', width: 120 },
        { field: 'paymentOwnerCard', headerName: 'Owner Card', width: 120 },
        { field: 'paymentDate', headerName: 'Date', width: 150 },
        { field: 'paymentValue', headerName: 'Value', width: 120 },
        { field: 'paymentState', headerName: 'Pay State', width: 120 },
        { 
            field: 'actions', 
            headerName: 'Actions',
            sortable: false,
            width: 100,
            disableClickEventBubbling: true,
            renderCell: (params) => (
                <div
                    style={{ cursor: "pointer" }}
                >
                    <Pay index={params.row} handleUpdateRegister= { habldeUpdateRegister } />
                </div>
            )
        }
    ]
    
    const peticion = () => {
        setPaymentsaux(paymentsOnly)
        setTablapayments(paymentsOnly)
    }

    const handleChange = e =>{
        setSearch(e.target.value)
        console.log(search)
        filtrar(e.target.value)
    }

    const filtrar = (itemSearch) => {
        var ownerSearch =  tablapayments.filter((item) =>  {
                if( item.ownerName.toLowerCase().includes(itemSearch.toLowerCase()) ){
                    return item;
                }
            });
            setPaymentsaux(ownerSearch);
    }

    React.useEffect(() =>{
        peticion();
    },[payments])

    const OnclickInsertar = () => {
        navigate({
            pathname: '/FormPayment'
        })
    }
    /*Sesiones*/
    useEffect(() => {
        if (typeof cookies.get('username') === 'undefined' ) {
            window.location.href = "./"
        }
    })

    useEffect(() => {
        if (cookies.get('ownerType') === "admin") {
            window.location.href = "./OwnerController"
        }
    })
    
    return ( 
   
        <Box
            sx={{
                width: '75%',
                height: '82vh',
                marginLeft:'auto',
                marginRight:'auto',
                justifyContent: 'center',
                display: 'flex',
                alignItems: 'center',
                flexDirection: 'column',
                paddingLeft:'20px',
                paddingRight:'20px',
                background: '#fff', 
                borderRadius: '15px',
                boxShadow: '1px 1px 20px #333'
            }}
        >

            <h1 style={{color:'black'}}>Payment's Pending</h1><br/>
            <div className="barraBusqueda">
                <input
                    type="text"
                    placeholder="Search"
                    className="textField"
                    name="busqueda"
                    value={ search }
                    onChange={ handleChange }
                />
                <button type="button" className="btnBuscar" >
                    <Stack direction="row" spacing={2}>
                        <Avatar sx={{ bgcolor: green[500], height: '45px', width: '45px'}}>
                            <PageviewIcon />
                        </Avatar>
                    </Stack>
                </button>
            </div>
           
            <div style={{ height: 400, width: '100%' }}>
                <DataGrid
                    rows=
                    {
                        paymentsOnly.map(item => (
                            {
                                id: item.id,
                                paymentPayCode: item.payCode,
                                paymentOwnerName: item.ownerName,
                                paymentOwnerCard: item.ownerCard,
                                paymentDate: item.date,
                                paymentValue: item.value,
                                paymentState: item.payState
                            }
                        ) )
                    }
                    
                    columns={columns}
                    pageSize={10}
                    rowsPerPageOptions={[10]}
                />
            </div>
        </Box>
    );
}
export default Payment